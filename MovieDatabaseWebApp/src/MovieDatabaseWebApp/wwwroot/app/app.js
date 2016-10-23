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
        if (!selected_genres | selected_genres.length == 0) {
            return items;
        }

        if (selected_genres.length == 1 && parseInt(selected_genres[0]) == 0) {
            // ALL category selected
            return items;
        }
        else {
            //get movies by genres
            var movies = [];
            angular.forEach(selected_genres, function (genre) {
                angular.forEach(items, function (movie) {
                    if (movie.categoryID == parseInt(genre)) {
                        movies.push(movie);
                    }
                });
            });

            return movies;
        };

        }
    }
);

moviesApp.filter('search_filter', function () {
    return function (items, keyword) {
        if (!keyword) {
            return items;
        }

        //get movies by search keyword
        var movies = [];
        angular.forEach(items, function (item) {
            if (item.title.toLowerCase().indexOf(keyword.toLowerCase()) !== -1) {
                movies.push(item);
            };
        });

        return movies;
    };
}

);