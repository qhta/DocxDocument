namespace ModelGen;

public class StringConstraint: Constraint
{
    public long? MinLength { get; set; }

    public long? MaxLength { get; set; }

    public long? Length { get; set; }

}