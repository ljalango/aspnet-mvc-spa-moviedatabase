var MovieDetailController = function ($routeParams) {
    $scope.movieId = $routeParams.movieId;
};
angular.module('moviesApp').component('movieDetail', {
    templateUrl: '/app/angulartemplates/moviedetail.html',
    controller: MovieDetailController
});