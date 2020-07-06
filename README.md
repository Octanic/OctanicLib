# OctanicLib
My personal Library for everything I shall use commonly on my .net projects

Obviously, not everything is/will be from my authorship, because the aim of this project is to make everything I use repeately on my projects into one thing. 
So instead of looking for how to do it or _reinvent the wheel_, I will have it on this lib.

Found at https://www.nuget.org/packages/octaniclib

# What does it do?
Since I am still reorganizing all my repeatable code through projects, I still have little contribution. But I am working on some Ideas.

Here is what I have

## List Extensions
A set of extension methods to help you deal with `ILists<T>`
<details>
  <summary>Shuffle</summary>
  Used to shuffle an <code>IList<T></code>. Usable for 
  <ul>
    <li>picking up random cards in a deck</li>
    <li>getting random products out of a set for a showcase</li>
    <li>mess up with an ordered list</li>
  </ul>
</details>

## String Extensions
Everything you need to do more with your strings

<details>
  <summary>RemoveAccents</summary>
  Remove accents (or diacritics if you want) from a string, so, <code>Animação</code> would be translated to <code>Animacao</code> - it uses Unicode character information.
</details>

# How to install it?
In your package manager, you can type in:
> Install-Package OctanicLib -Version 1.0.0

or, in your .NET CLI you can
> dotnet add package OctanicLib --version 1.0.0

# Final Words
This is a long term thing. Since I have worked on many very different projects, it may be a little troublesome to identify common things on them to put into this library. 
But I'll do it, and upload it here.

Also, as it grows, I will move the _what does it do_ section to a wiki.
