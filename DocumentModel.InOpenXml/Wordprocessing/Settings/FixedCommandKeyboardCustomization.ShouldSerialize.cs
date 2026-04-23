namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class FixedCommandKeyboardCustomization
{
  public bool ShouldSerializeCommandName() => !String.IsNullOrEmpty(CommandName);
  public bool ShouldSerializeCommandIndex() => CommandIndex is not null && ShouldSerialize(CommandIndex);
  public bool ShouldSerializeArgument() => Argument is not null && ShouldSerialize(Argument);
}
