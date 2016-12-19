(function () {
    var UsersListController = function ($scope, $http) {
        var getUsers = function () {
            $http.get('http://localhost:54030/api/User')
                .then(function (response) {
                    $scope.Users = response.data;
                });
        };
        getUsers();
    };

    var PetsListController = function ($scope, $http, $routeParams) { 
        $scope.userId = $routeParams.id;
        
        var getUserName = function () {
            $http.get('http://localhost:54030/api/User/' + $scope.userId)
                .then(function (response) {
                    $scope.username = response.data.Name;
                });
        };

        var getPets = function () {
            $http.get('http://localhost:54030/api/Pet/' + $scope.userId)
                .then(function (response) {
                    $scope.Pets = response.data;
                });
        };

        getUserName();
        getPets();
    };

    var UserAddController = function ($scope, $http, $route) {
        $scope.addUser = function () {
            $http.post('http://localhost:54030/api/User', '"' + $scope.name + '"')
                .then(function () {
                    $route.reload();
            });
        };
    };

    var PetAddController = function ($scope, $http, $route) {
        $scope.addPet = function () {
            $http.post('http://localhost:54030/api/Pet', '"' + $scope.name + ',' + $scope.userId + '"')
                .then(function () {
                    $route.reload();
                });
        };
    };

    var UserDeleteController = function ($scope, $http, $route) {
        $scope.deleteUser = function (userId) {
            $http.delete('http://localhost:54030/api/User/' + userId)
                .then(function () {
                    $route.reload();
                });
        };
    };

    var PetDeleteController = function ($scope, $http, $route) {
        $scope.deletePet = function (petId) {
            $http.delete('http://localhost:54030/api/Pet/' + petId)
                .then(function () {
                    $route.reload();
                });
        };
    };

    petsCatalogApp.controller('UsersListController', ['$scope', '$http', UsersListController]);
    petsCatalogApp.controller('PetsListController', ['$scope', '$http', '$routeParams', PetsListController]);
    petsCatalogApp.controller('UserAddController', ['$scope', '$http', '$route', UserAddController]);
    petsCatalogApp.controller('PetAddController', ['$scope', '$http', '$route', PetAddController]);
    petsCatalogApp.controller('UserDeleteController', ['$scope', '$http', '$route', UserDeleteController]);
    petsCatalogApp.controller('PetDeleteController', ['$scope', '$http', '$route', PetDeleteController]);
}());