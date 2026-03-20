
namespace DocumentModel.Interop.Core;

public partial interface CustomXMLValidationError: InteropObject
{
  public string Name { get; }
  public CustomXMLNode Node { get; }
  public string Text { get; }
  public MsoCustomXMLValidationErrorType Type { get; }
  public int ErrorCode { get; }
}
