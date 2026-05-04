using Qhta.OpenXmlTools;

namespace DocumentModel.InOpenXml.Test
{
	/// <summary>
	/// Comprehensive test for DocumentModel.DocumentVariables.
	/// </summary>
	public class DocumentVariablesTest: _AbstractTestClass
	{
    private readonly string TestFileName = Path.Combine(TestFileDir, "DocumentVariablesTest.docx");

    /// <summary>
    /// Runs all DocumentVariables serialization tests.
    /// </summary>
    /// <returns>True if all tests pass; otherwise, false.</returns>
    public override bool Run()
		{
			Console.WriteLine("=== DocumentVariables Test ===\n");
			if (!TestXmlSerialization()) return false;
			if (!TestJsonSerialization()) return false;
			if (!TestEdgeCases()) return false;
			if (!TestStoreInDocument()) return false;
			if (!TestUpdateInDocument()) return false;
			Console.WriteLine("All DocumentVariables tests passed.\n");
			return true;
		}

		/// <summary>
		/// Tests XML serialization and deserialization of DocumentVariables.
		/// </summary>
		/// <returns>True if the test passes; otherwise, false.</returns>
		private bool TestXmlSerialization()
		{
			Console.WriteLine("--- DocumentVariables XML Serialization ---");
			var testData = CreateSampleDocumentVariables();
			{
				var xmlSerializer = new XmlSerializer(typeof(DocumentVariables));
				string xmlString;
				using (var stringWriter = new StringWriter())
				using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
				{
					xmlSerializer.Serialize(xmlWriter, testData);
					xmlString = stringWriter.ToString();
				}
				Console.WriteLine("DocumentVariables Serialized XML:\n" + xmlString);

				DocumentVariables? deserialized;
				using (var stringReader = new StringReader(xmlString))
				{
					deserialized = (DocumentVariables?)xmlSerializer.Deserialize(stringReader);
				}
				if (deserialized == null)
				{
					Console.WriteLine("✗ DocumentVariables XML Deserialization returned null");
					return false;
				}
				if (!TestHelper.CompareTestData(testData, deserialized, "testData", "deserialized", out var message))
				{
					Console.WriteLine($"✗ DocumentVariables XML Serialization/Deserialization test FAILED: {message}");
					return false;
				}
				Console.WriteLine("✓ DocumentVariables XML Serialization/Deserialization test passed\n");
				return true;
			}
		}

		/// <summary>
		/// Tests JSON serialization and deserialization of DocumentVariables.
		/// </summary>
		/// <returns>True if the test passes; otherwise, false.</returns>
		private bool TestJsonSerialization()
		{
			Console.WriteLine("--- DocumentVariables JSON Serialization ---");
			var testData = CreateSampleDocumentVariables();
			{
        var jsonOptions = JsonConfig.Options;
				string jsonString = JsonSerializer.Serialize(testData, jsonOptions);
				Console.WriteLine("DocumentVariables Serialized JSON:\n" + jsonString);

				var deserialized = JsonSerializer.Deserialize<DocumentVariables>(jsonString, jsonOptions);
				if (deserialized == null)
				{
					Console.WriteLine("✗ DocumentVariables JSON Deserialization returned null");
					return false;
				}
				if (!TestHelper.CompareTestData(testData, deserialized, "testData", "deserialized", out var message))
				{
					Console.WriteLine($"✗ DocumentVariables JSON Serialization/Deserialization test FAILED: {message}");
					return false;
				}
				Console.WriteLine("✓ DocumentVariables JSON Serialization/Deserialization test passed\n");
				return true;
			}
		}

		/// <summary>
		/// Tests edge cases like empty DocumentVariables object.
		/// </summary>
		/// <returns>True if the test passes; otherwise, false.</returns>
		private bool TestEdgeCases()
		{
			Console.WriteLine("--- DocumentVariables Edge Cases ---");
			{
				var empty = new DocumentVariables();
				string xml = SerializeToXml(empty);
				var xmlDeserialized = DeserializeFromXml(xml);
				if (xmlDeserialized == null)
				{
					Console.WriteLine("✗ DocumentVariables Edge Cases: XML deserialization of empty object failed");
					return false;
				}
				string json = SerializeToJson(empty);
				var jsonDeserialized = DeserializeFromJson(json);
				if (jsonDeserialized == null)
				{
					Console.WriteLine("✗ DocumentVariables Edge Cases: JSON deserialization of empty object failed");
					return false;
				}
				Console.WriteLine("✓ DocumentVariables Edge case tests passed\n");
				return true;
			}
		}

		/// <summary>
		/// Tests setting sample DocumentVariables to a new document and outputs the result to the console.
		/// </summary>
		/// <remarks>This method is intended for use in test scenarios to verify that document DocumentVariables can
		/// be set and serialized correctly. It writes status messages and the serialized properties to the console for
		/// inspection.</remarks>
		/// <returns>true if the document DocumentVariables are successfully stored and verified; otherwise, false.</returns>
		private bool TestStoreInDocument()
		{
			Console.WriteLine("--- Store sample DocumentVariables in new document---");
			{
				DocumentVariables testData = CreateSampleDocumentVariables();
				using (var document = new Document(TestFileName, FileMode.CreateNew))
				{
					document.DocumentVariables = testData;
				}

        using (var wordDoc = DXPP.WordprocessingDocument.Open(TestFileName, false))
        {
          var outerXml = wordDoc.MainDocumentPart?.DocumentSettingsPart?.Settings?.GetDocumentVariables()?.OuterXml;
          outerXml = outerXml?.FormatXmlWithLineNumbers();
          Console.WriteLine("✓ Styles stored in document:\n" + outerXml);
        }

        DocumentVariables storedData;
				using (var document = new Document(TestFileName))
				{
					storedData = document.DocumentVariables ?? throw new InvalidOperationException("DocumentVariables not found.");
				}

				var xmlSerializer = new XmlSerializer(typeof(DocumentVariables));
				string xmlString;
				using (var stringWriter = new StringWriter())
				using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
				{
					xmlSerializer.Serialize(xmlWriter, storedData);
					xmlString = stringWriter.ToString();
				}
				Console.WriteLine("DocumentVariables stored to new document and reloaded from it:\n" + xmlString);

				if (!TestHelper.CompareTestData(testData, storedData, "testData", "storedData", out var message))
				{
					Console.WriteLine($"✗ Store sample DocumentVariables test FAILED: {message}");
					return false;
				}

				Console.WriteLine("✓ Store sample DocumentVariables test passed\n");
				return true;
			}
		}


		/// <summary>
		/// Tests updating the DocumentVariables of a document and outputs the result to the console.
		/// </summary>
		/// <remarks>This method is intended for use in test scenarios to verify that document DocumentVariables can
		/// be set and serialized correctly. It writes status messages and the serialized properties to the console for
		/// inspection.</remarks>
		/// <returns>true if the document DocumentVariables are successfully updated and verified; otherwise, false.</returns>
		private bool TestUpdateInDocument()
		{
			Console.WriteLine("--- Update document DocumentVariables ---");
			{
				DocumentVariables testData = CreateSampleDocumentVariables();
				var initialCount = testData.Count;
        var i = initialCount+1;
				using (var document = new Document(TestFileName, FileMode.CreateNew))
				{
					document.DocumentVariables = testData;
    			document.DocumentVariables.Add(new DocumentVariable { Name = $"Var{i}", Value = $"Value{i}" });
				}

				DocumentVariables storedData;
				using (var document = new Document(TestFileName))
				{
					storedData = document.DocumentVariables ?? throw new InvalidOperationException("DocumentVariables not found.");
				}

				var xmlSerializer = new XmlSerializer(typeof(DocumentVariables));
				string xmlString;
				using (var stringWriter = new StringWriter())
				using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
				{
					xmlSerializer.Serialize(xmlWriter, storedData);
					xmlString = stringWriter.ToString();
				}
				Console.WriteLine("Updated document DocumentVariables:\n" + xmlString);

				var storedCount = storedData.Count;
				if (storedCount != initialCount + 1)
				{
					Console.WriteLine($"✗ Updated document DocumentVariables test FAILED  - new property count is {storedCount}, expected {initialCount + 1}");
					return false;
				}

				Console.WriteLine("✓ Updated document DocumentVariables test passed\n");
				return true;
			}
		}


		/// <summary>
		/// Creates a sample DocumentVariables object with various property types.
		/// </summary>
		/// <returns>A populated DocumentVariables object.</returns>
		private DocumentVariables CreateSampleDocumentVariables()
		{
			var props = new DocumentVariables();
			for (int i=1; i<=10; i++)
			{
				props.Add(new DocumentVariable{ Name = $"Var{i}", Value = $"Value{i}" });
			}
			return props;
		}

		/// <summary>
		/// Serializes a DocumentVariables object to an XML string.
		/// </summary>
		/// <param name="props">The DocumentVariables object to serialize.</param>
		/// <returns>The serialized XML string.</returns>
		private string SerializeToXml(DocumentVariables props)
		{
			var xmlSerializer = new XmlSerializer(typeof(DocumentVariables));
			using (var stringWriter = new StringWriter())
			using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
			{
				xmlSerializer.Serialize(xmlWriter, props);
				return stringWriter.ToString();
			}
		}

		/// <summary>
		/// Deserializes a DocumentVariables object from an XML string.
		/// </summary>
		/// <param name="xml">The XML string to deserialize.</param>
		/// <returns>The deserialized DocumentVariables object, or null if deserialization fails.</returns>
		private DocumentVariables? DeserializeFromXml(string xml)
		{
			var xmlSerializer = new XmlSerializer(typeof(DocumentVariables));
			using (var stringReader = new StringReader(xml))
			{
				return (DocumentVariables?)xmlSerializer.Deserialize(stringReader);
			}
		}

		/// <summary>
		/// Serializes a DocumentVariables object to a JSON string.
		/// </summary>
		/// <param name="props">The DocumentVariables object to serialize.</param>
		/// <returns>The serialized JSON string.</returns>
		private string SerializeToJson(DocumentVariables props)
		{
			var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
			return JsonSerializer.Serialize(props, jsonOptions);
		}

		/// <summary>
		/// Deserializes a DocumentVariables object from a JSON string.
		/// </summary>
		/// <param name="json">The JSON string to deserialize.</param>
		/// <returns>The deserialized DocumentVariables object, or null if deserialization fails.</returns>
		private DocumentVariables? DeserializeFromJson(string json)
		{
			var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
			return JsonSerializer.Deserialize<DocumentVariables>(json, jsonOptions);
		}
	}
}