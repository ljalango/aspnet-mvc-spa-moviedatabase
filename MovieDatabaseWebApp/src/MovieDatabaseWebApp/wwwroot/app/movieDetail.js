var MovieDetailController = function ($scope) {
    $scope.title = "...Detail...";
};
angular.module('moviesApp').component('movieDetail', {
    templateUrl: '/app/angulartemplates/moviedetail.html',
    controller: MovieDetailController
});