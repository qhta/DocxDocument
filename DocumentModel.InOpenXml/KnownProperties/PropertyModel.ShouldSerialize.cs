namespace DocumentModel;
#pragma warning disable CS1591
public partial class PropertyModel
{
  public bool ShouldSerializeComponent() => Component is not null;
}
