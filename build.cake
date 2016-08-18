var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
  var greeting = "Hello World!";
  Information(greeting);
});

RunTarget(target);