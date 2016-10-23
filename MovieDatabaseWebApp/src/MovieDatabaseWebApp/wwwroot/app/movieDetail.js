var MovieDetailController = moviesApp.controller('MovieDetailController', function ($scope, $routeParams, moviesFactory) {
    $scope.movie = [];

    moviesFactory.getMovieDetails($routeParams.movieId).success(function (data) {
        $scope.movie.title = data.title;
        $scope.movie.year = data.year;
        $scope.movie.rating = data.rating;
        $scope.movie.description = data.description;
    }).error(function (error) {
        console.log("error getMovieById service");
    });
});