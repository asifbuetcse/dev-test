import { Component, OnInit } from '@angular/core';
import { FormArray, FormControl, FormGroup } from '@angular/forms';
import { HttpClientService } from 'src/app/http-client.service';

@Component({
  selector: 'app-survey-add',
  templateUrl: './survey-add.component.html',
  styleUrls: ['./survey-add.component.scss']
})
export class SurveyAddComponent implements OnInit {
  _client: HttpClientService;
  surveyForm = new FormGroup({
    Title: new FormControl(""),
    noOfQuestions: new FormControl(""),
    Questions: new FormArray(
      [

      ]
    ),
  },
  );

  constructor(client: HttpClientService) { this._client = client }

  ngOnInit(): void {
  }

  addQuestion() {
    const questions = this.surveyForm.get("Questions") as FormArray;
    questions.push(
      this.createQuestionFormGroup()
    )
    console.log(questions);
  }

  createAnswerFormGroup(count: number): FormArray {
    var x = new FormArray([]);
    for (let i = 0; i < count; i++) {
      x.push(new FormGroup(
        {
          'Text': new FormControl(""),
          'isCorrect': new FormControl(false),
        }))
    }
    console.log(x);
    return x;
  }

  createQuestionFormGroup(): FormGroup {
    return new FormGroup({
      'Text': new FormControl(''),
      'Answers': this.createAnswerFormGroup(4)
    })
  }

  getQuestionControls() {
    return this.surveyForm.controls['Questions'] as FormArray;
  }

  getAnswerControls(question: any) {
    console.log((question.controls['Answers'] as FormArray).controls);
    return question.controls['Answers'] as FormArray;
  }

  selectAnswer(i: number, j: number) {
  }

  save() {
    this._client.postData("survey", this.surveyForm.value).subscribe((res) => {
      console.log(res);
    });
  }

  cancel() {
  }
}
