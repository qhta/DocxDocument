namespace DocumentModel;

public partial class PropertyModel
{
  public bool ShouldSerializeComponent() => Component is not null;
}
