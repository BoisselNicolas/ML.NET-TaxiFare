<img src="https://blog.bracketshow.com/wp-content/uploads/2021/07/csharp.png" width="100px">

# ML.Net - TaxiFare

[![forthebadge](https://forthebadge.com/images/badges/built-with-love.svg)]()
[![forthebadge](https://forthebadge.com/images/badges/made-with-c-sharp.svg)](https://forthebadge.com)

[![Generic badge](https://img.shields.io/badge/For-Training-<green>.svg)](https://shields.io/)
[![Generic badge](https://img.shields.io/badge/Only-Terminal-<green>.svg)](https://shields.io/)
[![GPLv3 License](https://img.shields.io/badge/License-GPL%20v3-yellow.svg)]()


## Scénario 

Une application qui permet de connaître le prix d'une course en taxi en fonction de différents paramètres
</br>
<b>Algrithme :</b> regression

## Installation

```
$ git clone git@github.com:BoisselNicolas/ML.NET-TaxiFare.git
```

## Usage 

Dans le fichier "consumeModelApp/Program.cs"

Saisissez les données d'entrée dans la partie 

```
var input = new ModelInput(){
                Vendor_id = "CMT",
                Rate_code = Convert.ToSingle(1.0),
                Passenger_count = Convert.ToSingle(2.0),
                Trip_time_in_secs = Convert.ToSingle(2000.0),
                Trip_distance = Convert.ToSingle(5.0),
                Payment_type = "CRD"
            };
```

Pour éxécuter le programme

```
$ cd consumeModelApp
$ dotnet run 
```

## Résultat

Le programme nous retourne les informations que nous avons saisi plus le prix de la course 

``` 
vendor_id CMT
rate_code 1
passenger_count 2
trip_time_in_secs 2000
trip_distance 1,1
payment_type CRD
fare_amount : 13,984534
```

## Versions

**Dev :** 1.0


## Auteurs

* **BOISSEL Nicolas** 
