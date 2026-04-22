namespace DocumentModel.CustomUI;

#pragma warning disable CS1591

public partial class DialogBoxLauncher
{
  public bool ShouldSerializeButtonRegular() => ButtonRegular is not null;
}
