(function () {
    'use strict';

    angular
        .module('app')
        .controller('rentalController', rentalController);

    rentalController.$inject = ['$scope', '$http']; 

    function rentalController($scope, $http) {
        $scope.products = [];
        $scope.filteredProducts = [];
        $scope.title = 'rentalController';
        

        
        
        $scope.filterCaliber = function () {

            if ($scope.selectedItem === "All") {
                $scope.filteredProducts = $scope.products;
            }
            else {
                $scope.filteredProducts = $scope.products.filter(function (gun) { return gun.Caliber === $scope.selectedItem });
            }
            
        };
        activate();

        function activate() {
            $http.get("http://localhost:4877/Content/data.json").then(function (response) {
                $scope.products = response.data;
                $scope.filteredProducts = $scope.products;

            });
        }
    }
})();
