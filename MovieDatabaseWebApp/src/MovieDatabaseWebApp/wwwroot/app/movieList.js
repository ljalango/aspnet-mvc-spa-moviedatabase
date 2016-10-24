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

    //autocomplete

    $scope.keyword = "";
    $scope.suggestions = [];

    //on keyword change
    $scope.autocomplete = function () {
        
        $scope.suggestions = [];
  
        if (!$scope.keyword | $scope.keyword == "")
            return;

        //set filter option to "ALL"
        moviesFactory.getGenres().success(function (data) {
            $scope.genreData.genres = data;
            if ($scope.genreData.genres.length > 0) {
                var genreID = $scope.genreData.genres[0].id;
                $scope.genreData.model[0] = genreID;
            }
        }).error(function (error) {
            console.log("error getGenres service");
        });

        //search from all movies
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

        var maxListCount = 0;
        for (var i = 0; i < $scope.movies.length; i++) {
            var movie = $scope.movies[i];
            //title starts with keyword
            if (movie.title.toLowerCase().indexOf($scope.keyword) == 0) {
                $scope.suggestions.push(movie.title);
                maxListCount++;
            }
            if (maxListCount > 3)
                break;
        }
        
    };

    //on suggestion item click
    $scope.onSuggestionClick = function (selectedIndex) {
        //clicked selected suggestion at selectedIndex of autocomplete list
        $scope.keyword = $scope.suggestions[selectedIndex];
        $scope.suggestions = [];
    };

    $scope.onFilterChange = function () {
        $scope.keyword = "";
        $scope.suggestions = [];
    }
    
};

angular.module('moviesApp').component('movieList', {
    templateUrl: '/app/angulartemplates/movielist.html',
    controller: MovieListController
});