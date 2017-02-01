(function () {
    'use strict';

    angular
        .module('app')
        .controller('laneController', laneController);

    laneController.$inject = ['$scope', '$http']; 

    function laneController($scope, $http) {
        $scope.title = 'laneController';
        $scope.reservationForm = {
            'name': '',
            'reservationDate': new Date(),
            'reservationTime': ''
        };
        $scope.reservations = [];
        $scope.successMessage = "";
        $scope.errorMessage = "";
        $scope.originForm = angular.copy($scope.reservationForm);

        $scope.initialize = function (reservations) {
            $scope.reservations = reservations;
        };

        $scope.reserveLane = function () {
            $http.post('LaneRental/SaveReservation', { name: $scope.reservationForm.name, reservedDate: $scope.reservationForm.reservationDate, timeReserved: $scope.reservationForm.reservationTime })
            .then(function onSuccess(response) {
                $scope.reservationForm = angular.copy($scope.originForm);
                $scope.successMessage = "Your Lane has been reserved";
            }, function error(response) {
                $scope.errorMessage = response.errorMessage;
            })
        };

        $scope.formChanged = function () {
            $scope.successMessage = "";
            $scope.errorMessage = "";
        };

        

        activate();

        function activate() {
            
        }
    }
})();
