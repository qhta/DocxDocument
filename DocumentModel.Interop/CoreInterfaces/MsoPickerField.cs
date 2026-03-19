using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[Guid("C4B07795-AE88-400C-AF72-6F7F75A3EC0B")]
public enum MsoPickerField
{
  msoPickerFieldUnknown,
  msoPickerFieldDateTime,
  msoPickerFieldNumber,
  msoPickerFieldText,
  msoPickerFieldUser,
  msoPickerFieldMax
}