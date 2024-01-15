Factory Method Pattern

- The Factory Method Pattern defines 
- an interface for creating an object, 
- but lets subclasses decide which class to instantiate. 
- Factory Method lets a class defer instantiation to subclasses.


- Basically the SubClass decides what concrete object to create
- Only subclasses implement the "Factory Method" (Method used to Create stuff)
- Also the instantiation is separted from the normal code
- Also we are using interfaces and shet so we are cool now

- Also dependence Inversion is when instead of Lower Class Depending on higher class
- Both lower and higher class depend on an abstraction.
- Example Pizza store makes Pizza (an abstract type) and all Pizzas implement Pizza (an abstract type)
- Here there is no Concrete class between higher(PizzaStore) and lower(NYCheesePizza) classes 
