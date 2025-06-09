Version: 1.1

Projetc: Agenda  & Calendar
-------------------------------------
Windows Form;
Objetcs:
  - CheckedListBox: clbTarefas
  - Botões: btnInserir, btnRemover
  - Timer: Timer1
  - TextBox: txtTarefas
  - Label: lblHorario, lblData, lblPorcento
  - ProgressBar: pgrBarra
----------------------------
objectives:
A studying project that have an Database conection
--------------------------------------
Version 1.1:
  Database:
    I have created a database ( agenda ) and a table:

      CREATE TABLE Task (
        task_id INT AUTO_INCREMENT PRIMARY KEY,
        task_name VARCHAR(100) NOT NULL,
        task_description TEXT,
        task_completed BOOLEAN DEFAULT FALSE,
        task_priority ENUM('Low', 'Medium',  'High') DEFAULT 'Medium',
        task_date DATE NOT NULL,
        task_time TIME NOT NULL
      );

  Windows Forms:
    Description and priority options.
    Bug fixes.




