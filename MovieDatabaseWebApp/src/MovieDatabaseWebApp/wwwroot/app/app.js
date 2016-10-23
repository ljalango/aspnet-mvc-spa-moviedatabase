var moviesApp = angular.module('moviesApp', ['ngRoute']);

var serviceId = 'moviesFactory';

moviesApp.factory(serviceId,
    ['$http', moviesFactory]);

function moviesFactory($http) {
    var service = {};

    function getMovies() {
        return $http.get('/api/movies');
    }

    function getMovieDetails(id) {

        var request = $http({
            url: '/api/details',
            method: "GET",
            params: { movieId: id }
        });

        return request;
    }

    function getMovieById(id) {

        var request = $http({
            url: '/api/movie',
            method: "GET",
            params:  { movieId: id }
        });
        
        return request;
    }

    var service = {
        getMovies: getMovies,
        getMovieDetails: getMovieDetails
    };

    return service;
}

moviesApp.filter('genre_filter', function () {
        return function (items, genre) {
            //get movies by genre


            return items;
        };
    }
);