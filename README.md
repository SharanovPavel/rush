# Rush: Productive Ruby Features in C# .NET
Increase productivity by useful Ruby language features available in C# .NET.

[![Build status](https://ci.appveyor.com/api/projects/status/x8ihl9lq21fc838n?svg=true)](https://ci.appveyor.com/project/slavikdev/rush)

## Iterators
### Times iterator

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

### Each iterator

Ruby:
```ruby
"hello".each { |ch| print ch }
"message".each_with_index { |ch,i| puts "#{i} is #{ch}" }
```

C#:
```csharp
"hello".Each( ch => Console.Write( ch ) );
"message".Each( (ch, i) => Console.WriteLine( "{0} is {1}", i, ch ) );
```
