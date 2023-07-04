# Calculator

Данное решение основано на архитектурном паттерне MVP и включает следующие ключевые компоненты:

View: Класс представления отвечает за пользовательский интерфейс и обработку пользовательских действий.
Presenter: Класс презентера является посредником между представлением и данными. Он получает ввод пользователя от представления, выполняет вычисления с помощью парсера выражений и обновляет представление с результатом.
Expression Parser: Класс парсера выражений обрабатывает и вычисляет введенные пользователем выражения.
Calculator Repository: Класс репозитория калькулятора отвечает за управление сохранением и восстановлением активного выражения и хранение истории вычислений.

Все данные приложения сохраняются в PlayerPrefs.
