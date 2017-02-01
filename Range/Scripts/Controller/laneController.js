(function () {
    'use strict';

    angular
        .module('app')
        .controller('laneController', laneController);

    laneController.$inject = ['$scope', '$http']; 

    function laneController($scope, $http) {
        $scope.title = 'laneController';
        $scope.reservations = [];
        $scope.times = [];

        $scope.initialize = function (reservations) {
            $scope.reservations = reservations;
        };

        $scope.reserveLane = function () {
            $scope.name = $scope.nameForReservation;
            $scope.reservationDate = $scope.dateReserved;
            $scope.reservationTime = $scope.timeReserved;
            
            $http.post('LaneRentalController/SaveReservation', {$scope.name, $scope.reservationDate, $scope.reservationTime})
        }

        activate();

        function activate() {
            
        }
    }
})();
