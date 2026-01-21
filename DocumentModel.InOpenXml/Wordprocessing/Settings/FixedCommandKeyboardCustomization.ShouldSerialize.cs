namespace DocumentModel.Wordprocessing;

public partial class FixedCommandKeyboardCustomization
{
  public bool ShouldSerializeCommandName() => CommandName is not null;
  public bool ShouldSerializeCommandIndex() => CommandIndex is not null;
  public bool ShouldSerializeArgument() => Argument is not null;
}
