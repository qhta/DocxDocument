namespace DocumentModel.Properties;

public partial interface DocumentProperties
{
    public DocumentModel.Properties.CoreProperties? CoreProperties { get; set; }
    public DocumentModel.Properties.ExtendedProperties? ExtendedProperties { get; set; }
    public DocumentModel.Properties.CustomProperties? CustomProperties { get; set; }
    public int Count();

    public object? Get(string propName);

}