﻿var AddVehicleModelController = function ($scope, $http, $modalInstance, vehicleModelItem, vehicleMakeList) {
    $scope.vehicleModelItem = vehicleModelItem;
    $scope.VehicleMakeList = vehicleMakeList;
    $scope.IsSubmitted = false;
    $scope.SaveVehicleModel = function (isValid) {
        $scope.IsSubmitted = true;
        if (!isValid) {
            //save vehicle model
            $http({
                method: 'POST',
                url: '/VehicleModel/AddVehicleModel',
                data: $scope.vehicleModelItem,
                async: false,
            }).success(function (data, status, headers, config) {
                $modalInstance.close();
            });
        }
    };

    $scope.Cancel = function () {
        $modalInstance.dismiss('cancel');
    };
};