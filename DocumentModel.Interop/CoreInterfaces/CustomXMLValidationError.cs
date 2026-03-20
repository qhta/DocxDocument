
namespace DocumentModel.Interop.Core;

public interface CustomXMLValidationError: InteropObject
{
  string Name { get; }
  CustomXMLNode Node { get; }
  string Text { get; }
  MsoCustomXMLValidationErrorType Type { get; }
  void Delete();
  int ErrorCode { get; }
}