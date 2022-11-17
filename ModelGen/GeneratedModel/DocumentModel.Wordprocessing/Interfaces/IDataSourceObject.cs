namespace DocumentModel.Wordprocessing;

public interface IDataSourceObject // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IUdlConnectionString? UdlConnectionString { get ; set; }
  
  public IDataSourceTableName? DataSourceTableName { get ; set; }
  
  public ISourceReference? SourceReference { get ; set; }
  
  public IColumnDelimiter? ColumnDelimiter { get ; set; }
  
  public IMailMergeSource? MailMergeSource { get ; set; }
  
  public IFirstRowHeader? FirstRowHeader { get ; set; }
  
}
