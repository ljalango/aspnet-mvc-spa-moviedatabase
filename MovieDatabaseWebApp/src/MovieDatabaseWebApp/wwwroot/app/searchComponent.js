var SearchController = function ($scope) {

};
angular.module('moviesApp').component('searchComponent', {
    templateUrl: '/app/angulartemplates/search.html',
    controller: SearchController,
    bindings: { keyword: '<' }
});