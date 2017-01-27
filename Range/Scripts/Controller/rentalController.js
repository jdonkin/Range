(function () {
    'use strict';

    angular
        .module('app')
        .controller('rentalController', rentalController);

    rentalController.$inject = ['$scope']; 

    function rentalController($scope) {
        $scope.title = 'rentalController';

        activate();

        function activate() { }
    }
})();
