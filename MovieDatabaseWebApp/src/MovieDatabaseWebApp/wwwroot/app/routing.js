moviesApp.config([
  '$locationProvider', '$routeProvider',
  function ($locationProvider, $routeProvider) {
      $locationProvider.html5Mode({
          enabled: false,
          requireBase: true
      }).hashPrefix('!');
      $routeProvider
       .when('/', {
           templateUrl: '/app/angulartemplates/movies.html',
           controller: 'MoviesViewController'
       })
      .when('/moviedetail/:movieId', {
          templateUrl: '/app/angulartemplates/moviedetail.html',
          controller: 'MovieDetailController'
      })
      .when('/search', {
          templateUrl: '/app/angulartemplates/search_results.html',
          controller: 'SearchResultsController'
      })
      .when('/close', {
          templateUrl: '/app/angulartemplates/movies.html',
          controller: 'MoviesViewController'
      })
      .otherwise({
          templateUrl: '/app/angulartemplates/movies.html',
          controller: 'MoviesViewController'
      })
  }]);