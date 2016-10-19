moviesApp.config([
  '$locationProvider', '$routeProvider',
  function ($locationProvider, $routeProvider) {
      $locationProvider.html5Mode({
          enabled: false,
          requireBase: false
      }).hashPrefix('!');
      $routeProvider
      .when('/moviedetail/:movieId', {
          templateUrl: '/app/angulartemplates/moviedetail.html',
          controller: 'MovieDetailController'
      })
      .when('/about', {
          templateUrl: '/app/angulartemplates/about.html',
          controller: 'AboutController'
      })
      .otherwise({
          templateUrl: '/app/angulartemplates/movies.html',
          controller: 'MovieAppController'
      })
  }]);