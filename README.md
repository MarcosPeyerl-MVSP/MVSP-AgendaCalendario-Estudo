Version: 1.2

Projetc: Agenda  & Calendar
-------------------------------------
Windows Form;
Objetcs:
  - CheckedListBox: clbTarefas
  - Button: btnInserir, btnRemover
  - Timer: Timer1
  - TextBox: txtTarefas
  - Label: lblHorario, lblData, lblPorcento
  - ProgressBar: pgrBarra
  - tabControl: 
    - tabDescription
      - TextBox: txtDescription
      - Button: btnLimparDescription  
    - tapPriority
      - Button: btnPriorityLabel, btnPriority, btnChosePriority
----------------------------
objectives:
A studying project that have an Database conection
--------------------------------------
Version 1.2:
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
    - Description: Now you can put a Description of what you are going to do. 
    - Priority: You can chose thwe Priority of your Task
  
  Bug fixes:
    - Bug when you needed to remove the last Task.




