#include "letter_send.h"
#include "ui_letter_send.h"

using namespace std;

Letter_send::Letter_send(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::Letter_send)
{
    ui->setupUi(this);
}

void Letter_send::showEvent(QShowEvent *event)   //Ответ на письмо
{
    QWidget::showEvent(event);
    ui->lineEdit->setText(QString::fromStdString(sender_adderess)); //в lineEdit записываем от кого письмо
    sender_adderess = ""; //очищаем
}

Letter_send::~Letter_send()
{
    delete ui;
}

void Letter_send::on_pushButton_clicked()   //забираем содержимое виджетов кому письмо(адрес), текст письма(леттер)
{
    string address = ui->lineEdit->text().toStdString();
    string letter = ui->textEdit->toPlainText().toStdString();
}
