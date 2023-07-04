# Calculator

Данное решение основано на архитектурном паттерне MVP и включает следующие ключевые компоненты:<br>

<b>View</b>: Класс представления отвечает за пользовательский интерфейс и обработку пользовательских действий.<br>
<b>Presenter</b>: Класс презентера является посредником между представлением и данными. Он получает ввод пользователя от представления, выполняет вычисления с помощью парсера выражений и обновляет представление с результатом.<br>
<b>Expression Parser</b>: Класс парсера выражений обрабатывает и вычисляет введенные пользователем выражения.<br>
<b>Calculator Repository</b>: Класс репозитория калькулятора отвечает за управление сохранением и восстановлением активного выражения и хранение истории вычислений.<br><br>

Все данные приложения сохраняются в PlayerPrefs.
