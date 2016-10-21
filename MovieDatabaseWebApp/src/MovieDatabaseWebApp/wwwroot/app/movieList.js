var MovieListController = function ($scope, moviesFactory) {
    $scope.movies = [];

    moviesFactory.getMovies().success(function (data) {
        $scope.movies = data;
    }).error(function (error) {
        console.log("error getMovies service"); 
    });

};

angular.module('moviesApp').component('movieList', {
    templateUrl: '/app/angulartemplates/movielist.html',
    controller: MovieListController
});