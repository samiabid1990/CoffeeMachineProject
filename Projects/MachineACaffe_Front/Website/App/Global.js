var mainModule = angular.module('mainModule', ['ngMaterial', 'ngMessages']);

mainModule.controller('mainController', ['$scope', '$http', '$mdDialog', function ($scope, $http, $mdDialog) {

    $scope.coffeOrder = {};
    $scope.badgeDeCommande = "";

    $scope.SaveOrder = function (ev) {
        $http.post('/Save/SaveOrder', { "coffeOrder": JSON.stringify($scope.coffeOrder) })
             .then(function (result) {
                 showGeneratedBadge(ev, result.data);
             });
    }

    $scope.GetLatestBadgeOrder = function (ev) {
        if ($scope.badgeDeCommande == '' || $scope.coffeOrder.badge == $scope.badgeDeCommande) {
            NotifyLoadCommande(ev, 'Veuillez saisir un identifiant du badge!');
            return;
        }

        $http.get('api/GetLatestBadgeOrder', { params: { "badge": $scope.badgeDeCommande } })
             .then(function (result) {
                 if (!angular.isUndefined(result.data) && result.data != "null") {
                     $scope.coffeOrder = JSON.parse(result.data);
                     NotifyLoadCommande(ev, 'Commande chargée correctement!');
                 }
                 else {
                     NotifyLoadCommande(ev, 'Aucune commande n\'a été trouvée pour ce badge');
                 }
             });
    }


    function showGeneratedBadge(ev, generatedBadge) {
        var message = "";
        if (generatedBadge != "update")
            message = 'Votre commande est passée avec succés! \n Voici votre badge :  ' + generatedBadge + ' généré pour mémorisé ce choix';
        else
            message = 'Votre commande est passée avec succés! Savourez votre boisson.';
        $mdDialog.show(
          $mdDialog.alert()
            .parent(document.body)
            .clickOutsideToClose(false)
            .title(message)
            .ok('OK')
            .targetEvent(ev)
        );
    };

    function NotifyLoadCommande(ev, message) {
        $mdDialog.show(
          $mdDialog.alert()
            .parent(document.body)
            .clickOutsideToClose(false)
            .title(message)
            .ok('OK')
            .targetEvent(ev)
        );
    };

}]);

