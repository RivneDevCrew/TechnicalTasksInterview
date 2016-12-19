var petsCatalogApp = angular.module('petsCatalogApp', ['ngRoute']);

petsCatalogApp.config(function ($routeProvider, $locationProvider) {
    $routeProvider
        .when('/', {
            templateUrl: 'Scripts/app/index.html',
            controller: 'UsersListController'
        })
        .when('/user/:id', {
            templateUrl: '../Scripts/app/pets.html',
            controller: 'PetsListController'
        });
    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false
    });
});