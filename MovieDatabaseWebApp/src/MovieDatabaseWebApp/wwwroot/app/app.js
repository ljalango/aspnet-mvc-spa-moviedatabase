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

    function getGenres() {
        return $http.get('/api/genres');
    }

    var service = {
        getMovies: getMovies,
        getMovieDetails: getMovieDetails,
        getGenres: getGenres
    };

    return service;
}

moviesApp.filter('genre_filter', function () {
        return function (items, selected_genres) {
            //get movies by genres


            return items;
        };
    }
);