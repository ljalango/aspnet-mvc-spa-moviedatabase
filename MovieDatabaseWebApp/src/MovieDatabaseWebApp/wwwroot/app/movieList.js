var MovieListController = function () {
    var ctrl = this;
    ctrl.list = [
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
    ];
};
angular.module('moviesApp').component('movieList', {
    templateUrl: '/app/angulartemplates/movielist.html',
    controller: MovieListController,
    controllerAs: 'ctrl'
});