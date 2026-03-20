
namespace DocumentModel.Interop.Core;

public interface CustomXMLValidationError: InteropObject
{
  public string Name { get; }
  public CustomXMLNode Node { get; }
  public string Text { get; }
  public MsoCustomXMLValidationErrorType Type { get; }
  public void Delete();
  public int ErrorCode { get; }
}
