namespace ModelGen;

/// <summary>
/// Abstract base class of constaint applied to model element or property
/// </summary>
[KnownType(typeof(NumberConstraint))]
[KnownType(typeof(StringConstraint))]
public abstract record Constraint
{
}