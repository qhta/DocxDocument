using System.Reflection;

using DocumentModel.OpenXml;

using Qhta.TypeUtils;

namespace DocxDocument.Reader.Test;
public class TestConverters : TestBase
{

  [Test]
  public void TestEnumOpenXmlLeafElementConverter()
  {
    var modelAssembly = Assembly.Load("DocumentModel");
    var sourceAssembly = Assembly.Load("DocumentFormat.OpenXml");
    var enumTypesList = new List<Type>();
    foreach (var type in sourceAssembly.GetTypes())
    {
      if (type.IsEqualOrSubclassOf(typeof(DocumentFormat.OpenXml.OpenXmlLeafElement)))
      {
        var valProperty = type.GetProperty("Val");
        if (valProperty != null)
        {
          var propType = valProperty.PropertyType;
          if (propType.Name.StartsWith("EnumValue"))
          {
            var argType = propType.GenericTypeArguments.FirstOrDefault();
            if (argType != null && argType.IsEnum)
            {
              if (!enumTypesList.Contains(argType))
              {
                enumTypesList.Add(argType);
                WriteLine($"{argType.FullName}");
                var modelTypeName = argType.Name.Replace("Values", "Kind");
                var modelTypeNamespace = argType.Namespace?.Replace("DocumentFormat.OpenXml", "DocumentModel") ?? string.Empty;
                var modelTypeFullName = modelTypeNamespace + "." + modelTypeName;
                var modelType = modelAssembly.GetType(modelTypeFullName);
                if (modelType == null)
                  WriteLine($"  no model type \"{modelTypeFullName}\" found");
                else
                {
                  WriteLine($"  --> {modelType.FullName}");
                  foreach (var origEnumVal in argType.GetEnumValues())
                  {
                    var enumValueType = typeof(DocumentFormat.OpenXml.EnumValue<>).MakeGenericType(argType);
                    Assert.That(enumValueType, Is.Not.Null);
                    if (enumValueType != null)
                    {
                      var origEnumValue = enumValueType.GetConstructor(new Type[] { argType })?.Invoke(new object[] { origEnumVal });
                      Assert.That(origEnumValue, Is.Not.Null);
                      if (origEnumValue != null)
                      {
                        var convertToModelMethod = typeof(EnumValueConverter).GetMethod(nameof(EnumValueConverter.GetValue));
                        Assert.That(convertToModelMethod, Is.Not.Null);
                        var convertFromModelMethod = typeof(EnumValueConverter).GetMethod(nameof(EnumValueConverter.CreateOpenXmlElement));
                        Assert.That(convertFromModelMethod, Is.Not.Null);
                        if (convertToModelMethod != null && convertFromModelMethod != null)
                        {
                          if (convertToModelMethod.ContainsGenericParameters)
                          {
                            // var modelEnumValue = EnumValueConverter.CreateModelElement<argType, modelType>(origEnumVal);
                            var convertToModelGenericMethod = convertToModelMethod.MakeGenericMethod(argType, modelType);
                            var modelEnumValue = convertToModelGenericMethod.Invoke(null, new object[] { origEnumValue });
                            Assert.That(modelEnumValue, Is.Not.Null);
                            if (modelEnumValue != null)
                            {
                              // var elementEnumValue = EnumValueConverter.CreateOpenXmlElement<argType, modelType>(origEnumVal);
                              var convertFromModelGenericMethod = convertFromModelMethod.MakeGenericMethod(propType, argType, modelType);
                              var convEnumValue = convertFromModelGenericMethod.Invoke(null, new object[] { modelEnumValue });
                              Assert.That(convEnumValue, Is.Not.Null);
                              if (convEnumValue != null)
                              {
                                Assert.That(convEnumValue.GetType, Is.EqualTo(origEnumValue.GetType()));
                                var convEnumVal = convEnumValue.GetType()?.GetProperty("Value")?.GetValue(convEnumValue);
                                Assert.That(convEnumVal, Is.Not.Null);
                                if (convEnumVal != null)
                                {
                                  Assert.That(convEnumVal, Is.EqualTo(origEnumVal));
                                }
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
      }
    }
  }
}



