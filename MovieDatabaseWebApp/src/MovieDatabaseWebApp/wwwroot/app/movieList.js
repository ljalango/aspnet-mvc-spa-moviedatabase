var MovieListController = function ($scope) {
    $scope.movies = [
        {
            Id: 1,
            title: "TestMovie1",
            year: 1900
        },
        {
            Id: 2,
            title: "TestMovie2",
            year: 1901
        },
        {
            Id: 3,
            title: "TestMovie3",
            year: 1902
        },
        {
            Id: 4,
            title: "TestMovie4",
            year: 1903
        },
        {
            Id: 5,
            title: "TestMovie5",
            year: 1904
        }
    ];
};
angular.module('moviesApp').component('movieList', {
    templateUrl: '/app/angulartemplates/movielist.html',
    controller: MovieListController,
    bindings: {movie: '='}
});