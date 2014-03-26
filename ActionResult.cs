namespace ModelsLibrary
{
    public struct ActionResult
    {
        public bool Success;
        public string Message;

        public ActionResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }
}