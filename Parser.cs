namespace CodeParser
{
    public class Parser
    {
        private readonly string _errorMessage = "No content in file, check file path.";
        private string _content;
        public Parser(string pathToFile)
        {
            Stream stream = File.OpenRead(pathToFile);
            StreamReader sr = new StreamReader(stream);
            _content = sr.ReadToEnd();
        }
        public void ReplaceEscapeCharacters()
        {
            validateContent();
            _content.Replace("\n", "");
            _content.Replace("\t", "");
        }
        public string GetFormattedContent()
        {
            validateContent();
            return _content;
        }

        private void validateContent()
        {
            if (string.IsNullOrEmpty(_content))
            {
                throw new Exception(_errorMessage);
            }
        }
    }
}