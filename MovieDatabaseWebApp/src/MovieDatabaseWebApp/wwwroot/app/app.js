var moviesApp = angular.module('moviesApp', ['ngRoute']);

var serviceId = 'moviesFactory';

moviesApp.factory(serviceId,
    ['$http', moviesFactory]);

function moviesFactory($http) {
    var service = {};

    function getMovieById(id) {

        var request = $http({
            url: '/api/movie',
            method: "GET",
            params:  { movieId: id }
        });
        
        return request;
    }

    function getMovies() {
        return $http.get('/api/movies');
    }

    var service = {
        getMovieById: getMovieById,
        getMovies: getMovies
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