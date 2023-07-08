using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
namespace Calculator.Data
{

    public class HistoryRepository : IHistoryRepository
    {
        private List<ExpressionModel> _history = new List<ExpressionModel>();

        private const string HISTORY_DATA_KEY = "History";

        public IEnumerable<ExpressionModel> GetHistory()
        {
            return _history;
        }

        public void AddHistory(ExpressionModel history)
        {
            _history.Add(history);
            SaveHistory();
        }

        private void SaveHistory()
        {
            string serializedHistory = JsonConvert.SerializeObject(_history);

            PlayerPrefs.SetString(HISTORY_DATA_KEY, serializedHistory);
            PlayerPrefs.Save();
        }

        public void LoadData()
        {
            string serializedHistory = PlayerPrefs.GetString(HISTORY_DATA_KEY, "");

            List<ExpressionModel> history = JsonConvert.DeserializeObject<List<ExpressionModel>>(serializedHistory);
            history ??= new List<ExpressionModel>();

            _history = history;
        }
    }
}
