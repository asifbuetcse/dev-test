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
    Questions: new FormArray(
      [
        new FormGroup(
          {
            Text: new FormControl(""),
            Answers: new FormArray(
              [
                new FormGroup(
                  {
                    Text: new FormControl(""),
                    isCorrect: new FormControl(false),
                  }
                ),
                new FormGroup(
                  {
                    Text: new FormControl(""),
                    isCorrect: new FormControl(false),
                  }
                ),
                new FormGroup(
                  {
                    Text: new FormControl(""),
                    isCorrect: new FormControl(false),
                  }
                ),
                new FormGroup(
                  {
                    Text: new FormControl(""),
                    isCorrect: new FormControl(false),
                  }
                ),
              ]
            )
          }
        ),
        new FormGroup(
          {
            Text: new FormControl(""),
            Answers: new FormArray(
              [
                new FormGroup(
                  {
                    Text: new FormControl(""),
                    isCorrect: new FormControl(false),
                  }
                ),
                new FormGroup(
                  {
                    Text: new FormControl(""),
                    isCorrect: new FormControl(false),
                  }
                ),
                new FormGroup(
                  {
                    Text: new FormControl(""),
                    isCorrect: new FormControl(false),
                  }
                ),
                new FormGroup(
                  {
                    Text: new FormControl(""),
                    isCorrect: new FormControl(false),
                  }
                ),
              ]
            )
          }
        ),
        new FormGroup(
          {
            Text: new FormControl(""),
            Answers: new FormArray(
              [
                new FormGroup(
                  {
                    Text: new FormControl(""),
                    isCorrect: new FormControl(false),
                  }
                ),
                new FormGroup(
                  {
                    Text: new FormControl(""),
                    isCorrect: new FormControl(false),
                  }
                ),
                new FormGroup(
                  {
                    Text: new FormControl(""),
                    isCorrect: new FormControl(false),
                  }
                ),
                new FormGroup(
                  {
                    Text: new FormControl(""),
                    isCorrect: new FormControl(false),
                  }
                ),
              ]
            )
          }
        ),
      ]
    ),
  });

  constructor(client: HttpClientService) { this._client = client }

  ngOnInit(): void {
  }

  getQuestionControls() {
    return this.surveyForm.controls['Questions'] as FormArray;
  }

  getAnswerControls(question: any) {
    console.log(question['Answers'] as FormArray);
    return question['Answers'];
  }

  selectAnswer(i: number, j: number) {
  }

  save() {
    this._client.postData("survey", this.surveyForm.value).subscribe((res) => {
      console.log(res);
    });
  }

  cancel() {
    this.surveyForm = new FormGroup({
      title: new FormControl(),
      Questions: new FormArray(
        [
          new FormGroup(
            {
              Text: new FormControl(""),
              Answers: new FormArray(
                [
                  new FormGroup(
                    {
                      Text: new FormControl(""),
                      isCorrect: new FormControl(false),
                    }
                  ),
                  new FormGroup(
                    {
                      Text: new FormControl(""),
                      isCorrect: new FormControl(false),
                    }
                  ),
                  new FormGroup(
                    {
                      Text: new FormControl(""),
                      isCorrect: new FormControl(false),
                    }
                  ),
                  new FormGroup(
                    {
                      Text: new FormControl(""),
                      isCorrect: new FormControl(false),
                    }
                  ),
                ]
              )
            }
          ),
          new FormGroup(
            {
              Text: new FormControl(""),
              Answers: new FormArray(
                [
                  new FormGroup(
                    {
                      Text: new FormControl(""),
                      isCorrect: new FormControl(false),
                    }
                  ),
                  new FormGroup(
                    {
                      Text: new FormControl(""),
                      isCorrect: new FormControl(false),
                    }
                  ),
                  new FormGroup(
                    {
                      Text: new FormControl(""),
                      isCorrect: new FormControl(false),
                    }
                  ),
                  new FormGroup(
                    {
                      Text: new FormControl(""),
                      isCorrect: new FormControl(false),
                    }
                  ),
                ]
              )
            }
          ),
          new FormGroup(
            {
              Text: new FormControl(""),
              Answers: new FormArray(
                [
                  new FormGroup(
                    {
                      Text: new FormControl(""),
                      isCorrect: new FormControl(false),
                    }
                  ),
                  new FormGroup(
                    {
                      Text: new FormControl(""),
                      isCorrect: new FormControl(false),
                    }
                  ),
                  new FormGroup(
                    {
                      Text: new FormControl(""),
                      isCorrect: new FormControl(false),
                    }
                  ),
                  new FormGroup(
                    {
                      Text: new FormControl(""),
                      isCorrect: new FormControl(false),
                    }
                  ),
                ]
              )
            }
          ),
        ]
      ),
    });
  }
}
