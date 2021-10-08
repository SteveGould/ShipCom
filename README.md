# ShipCom

In this solution, I tried to keep it simple and uncomplicated.  There is a lot more I could and would do if this were production code.  For example, there is no error checking for invalid color names.  I am assuming the happy path.  With error handling, the unit tests should test the unhappy paths, too.

I coded the Resistor class to inherit the IOhmValueCalculator interface.  Way more could have been done in that class, but it wasn’t in the spec. I noticed that capacitors were similar, so I am thinking this could be refactored to abstract out a base type and inject a concrete implementation using a factory pattern perhaps.  

I coded the implementation based on the documentation of the parameters.  Tolerances were not a returned value, so bandDColor was essentially ignored.

I created a static class, ResistorColorBands, to hold the values in the chart.  The code asked for these values to be read from a database.  To properly do this, I would want to create a service layer and a repository layer.  That would take several more hours.  I wanted to get this to you for evaluation.  I spoke with Mo and he suggested that I just describe how I would implement.  Then, if necessary, I could code it.

I wrote this as a console application for speed of development.  I did not answer part 3 as I have never coded in React and it has been years since I coded in Angular.  And it was Angular 1 at that.

Had I written an API, I would have had it as an HTTP GET inputting the four band colors.  I would then pass that to the service class (in this case similar to the OhmValueCalculator class) which would perform any logic necessary. Part of the logic would be to make a call to the repository class to get the data for the calculations.  The repository class would in turn make the database call requesting the values that are essentially in the ResistorColorBands.  After having retrieved the data, the service layer would make the calculations and pass the final value back to the API for return.

If you have any questions, do not hesitate to contact me at 
503-704-7047
Steve@ExactlyMyPoint.com

