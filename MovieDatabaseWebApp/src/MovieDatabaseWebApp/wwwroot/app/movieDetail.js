var MovieDetailController = moviesApp.controller('MovieDetailController', function ($scope, $routeParams, moviesFactory) {
    var id = $routeParams.movieId;
    moviesFactory.getMovieById($routeParams.movieId).success(function (data) {
        $scope.movie = data;
    }).error(function (error) {
        console.log("error getMovieById service");
    });
});