# ExcellentGeometry
Library to calculate areas and other geometrical characteristics of different shapes.

These calculations do not guarantee any precision or accuracy. I.e., precision is enough for drawing figures or to deal with school exercises, but you should not use this library for real high-accuracy engineering calculations.

As a bonus (!), you can find beautiful DoublesComparer in ExcellentGeometry.Utils namespace. It allows you to... Compare doubles! Compare them with any precition you wish!

# Example code

Create triangle:
```
var triangle = new Triangle(10, 20, 15);
```

Get triangle properties:
```
var area = triangle.GetArea();
var isTriangleARightTriangle = triangle.IsRightTriangle;
```

Create circle:
```
var circle = new Circle(10);
```

Get circle properties:
```
var radius = circle.Radius;
var diameter = circle.Diameter;
var area = circle.GetArea();
```

Get area of any shape:
```
IShape triangle = new Triangle(1, 2, 3);
IShape circle = new Circle(4);

foreach (IShape shape in new[] { triangle, circle })
{
  var area = shape.GetArea();
}
```
