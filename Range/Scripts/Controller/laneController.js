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

            $http.post('LaneRental/SaveReservation', { name: $scope.name, reservedDate: $scope.reservationDate, timeReserved: $scope.reservationTime })
            .then(function onSuccess(response) {
                $scope.reservationForm.$setPristine();
            });
        };

        activate();

        function activate() {
            
        }
    }
})();
