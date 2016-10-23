var MovieListController = function ($scope, moviesFactory) {
    $scope.genreData = {
        model: [],
        genres: []
    };
    
    $scope.movies = [];

    moviesFactory.getGenres().success(function (data) {
        $scope.genreData.genres = data;
        if ($scope.genreData.genres.length > 0)
        {
            var genreID = $scope.genreData.genres[0].id;
            $scope.genreData.model[0] = genreID;
        }
    }).error(function (error) {
        console.log("error getGenres service");
    });

    moviesFactory.getMovies().success(function (data) {
        $scope.movies = data;

        angular.forEach($scope.movies, function (movie) {
            angular.forEach($scope.genreData.genres, function (genre) {
                if (movie.categoryID == genre.id) {
                    movie.genre = genre.name;
                }
            });
        });

    }).error(function (error) {
        console.log("error getMovies service"); 
    });
};

angular.module('moviesApp').component('movieList', {
    templateUrl: '/app/angulartemplates/movielist.html',
    controller: MovieListController
});