# Rush: Little Ruby things in C&#35;
Ruby offers flexible and short structures which simplify coding. This library adapts some of them in C#.

[![Build status](https://ci.appveyor.com/api/projects/status/x8ihl9lq21fc838n?svg=true)](https://ci.appveyor.com/project/slavikdev/rush)

## Loops
### Times loop

Ruby:
```ruby
5.times { puts "Hello" }
10.times { |i| puts "Hello #{i}" }
```

C#:
```csharp
5.Times( () => Console.WriteLine( "Hello" ) );
10.Times( i => Console.WriteLine( "Hello, {0}", i ) );
```
