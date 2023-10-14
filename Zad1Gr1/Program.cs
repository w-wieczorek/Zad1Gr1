// See https://aka.ms/new-console-template for more information

using System.Collections.Immutable;
using Zad1Gr1;

List<ImmutableHashSet<int>> subsets = new();
subsets.Add(ImmutableHashSet.Create(0, 1, 3));
subsets.Add(ImmutableHashSet.Create(1, 2, 3));
subsets.Add(ImmutableHashSet.Create(2, 3));
LinearModel.BuildAndSolve(4, 3, subsets);
