# Stellar Trader Overview

## Concept

You have inherited a transport ship and a small cargo depot on Phobos, along with a paltry amount of money.
You must use your inheritence and wits to build a shipping and manufacturing empire.

## Features

* Fully modeled solar systems, where planets and moons travel through their orbits as you play.  Since ships
consume fuel and must use sub-lightspeed drives when travelling within a solar system, penny-pinching can
include waiting for the opportune time to send a ship between solar bodies.
* Anyone can transport goods in-system, but you must acquire special ships and permits to traverse the slipknots
between solar systems.
* When your reputation and influence on a planet or moon has grown, you may build factories, mines, and refineries.
* When your status within a system is sufficent, you can purcahse the permits required to build space stations and
other features.

## Development Plan

### Phase One
1. Develop items and markets.  Items hold base values and production requirements.  Markets hold quantities and adjust
price based on supply.
2. Develop populations.  Populations have personality, which determines how quickly they consume different items
from their market, thus influencing supply.
3. Add demand modelling to markets.  Adjust prices based on population personality, with higher demand items becoming
more expensive until the market is saturated.

### Phase Two
1. Add stellar bodies.  Bodies have parents (the body they orbit) and orbital parameters defining their motion.  Bodies
are associated with a market, providing distance between markets that will vary over time.
2. Add trade vessels with speed, fuel capacity, and cargo capacity.  Phase two vessels will travel in a straight line
toward their destination, altering course as the destination moves.

### Phase Three
1. Add production facilities which can produce items if their requirements are available in the market.
2. Track production cost of items based on the price of the required items at time of production.

### Phase Four
1. Add computer-controlled traders.
2. Add market events that will alter demand for goods.
3. Allow markets to alter demand based on distance to closest in-system source of items.  (I.e., Solar Panels are
cheaper when the moon that manufactures them is in perigee.)

### Phase Five
1. Add computer-controlled pirates and raiders.
2. Add custom-fitting of vessels to alter characteristics, add weapons, shielding, etc.

### Phase Six
1. Add reputation system, allowing players to perform actions to improve their reputation with a market.
2. Add player-constructed production facilities.

### Phase Seven
1. Add solar systems, and incorporate systems into repuation logic.
2. Add slipknot drives as customizable feature of vessels.  Incorporate inter-system travel into computer-controlled
traders.

### Phase Eight
1. Profit? :)
