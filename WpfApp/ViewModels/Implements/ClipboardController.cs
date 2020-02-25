﻿using MultiBuffer.WpfApp.Models.Interfaces;
using TextCopy;

namespace MultiBuffer.WpfApp.ViewModels.Implements
{
    public class ClipboardController : IClipboardController
    {
        /// <summary>
        /// Устанавливает текст в буфер обмена
        /// </summary>
        /// <param name="value">Текст, который необходимо передать</param>
        public string GetText()
        {
            return Clipboard.GetText();
        }

        /// <summary>
        /// Получает текст из буфера обмена
        /// </summary>
        /// <returns>Строка с текстом, полученная из буфера</returns>
        public void SetText(string value)
        {
            Clipboard.SetText(value);
        }
    }
}