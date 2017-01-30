(function () {
    'use strict';

    angular
        .module('app')
        .controller('rentalController', rentalController);

    rentalController.$inject = ['$scope', '$http']; 

    function rentalController($scope, $http) {
        $scope.title = 'rentalController';
        

        $http.get("http://localhost:4877/Content/data.json").then(function (response) {
            $scope.products = response.data;

        });
        
        $scope.filterCaliber = function () {
            $scope.caliber = $scope.selectedItem;
            alert($scope.caliber);
        };
        activate();

        function activate() { }
    }
})();
