## Описание:<br/>
Данный README-файл написан для проекта 6ой практической работы "СОЗДАНИЕ АВТОМАТИЗИРОВАННЫХ UNIT-ТЕСТОВ Часть 1"<br/> 
по дисциплине "Поддержка и тестирование программных модулей".<br/>

#### Цель работы:
Провести тестирование разработанных программных модулей с использованием средств автоматизации Microsoft Visual Studio методом "белого ящика".<br/> 

Разработчики: Краснова А.А. и Солодов А.Е.<br/> 
Учебная группа: 3ИСИП-123 <br/> 

#### Используемый стек технологий:
 - C#
 - С# (XML Documentation)
 - Проект Модульного теста для языка C# (.NET Framework)

#### Описание архитектуры:<br/>
Весь проект выполнен на бэкенд части, реализован основной проект Bank и проект для тестов BankTests.<br/>

## Структура проекта:
```
Pr_6_Krasnova_Solodov/
| ├── Bank/
| |   ├── Properties/
| |   ├── App.xaml.cs
| |   ├── Bank.csproj
| |   ├── BankAccount.cs
| └── BankTests/
|     ├── Properties/
|     ├── BankAccountTests.cs
|     ├── BankTests.csproj
|     └── packages.config
├── .gitattributes
├── .gitignore
└── Bank.sln
```

## Основные компоненты:
2 объекта FileName.cs.

========== BankAccount.cs: ==========
 - Класс BancAccount
 - Конструктор класса
 - Функция CustomerName возвращающий имя
 - Функция Balance возвращающий баланс
 - Метод Debit() с обработкой исключений (уменьшает баланс)
 - Метод Credit() с обработкой исключений (увеличивает баланс)
 - Метод Main() для работы

========== BankAccountTests.cs: ==========
 - [TestClass] BankAccountTests содержащий юнит-тесты
 - [TestMethod] Debit_WithValidAmount_UpdatesBalance()
 - [TestMethod] Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
 - [TestMethod] Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
 - [TestMethod] Credit_WithValidAmount_UpdatesBalance()
 - [TestMethod] Credit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()


#### Взаимодействие:<br/>
Работа со всеми методами происходит в теле метода Main() с использованием функций и методов внутри класса.<br/>

#### Вывод о проведенном тестировании:<br/>
Все юнит-тесты прошли успешно!<br/>
