namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class FixedCommandKeyboardCustomization
{
  public bool ShouldSerializeCommandName() => CommandName is not null;
  public bool ShouldSerializeCommandIndex() => CommandIndex is not null;
  public bool ShouldSerializeArgument() => Argument is not null;
}
